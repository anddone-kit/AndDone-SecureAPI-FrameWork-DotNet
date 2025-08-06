using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace APISample;
public class JsonTreeView : TreeView
{
    private JToken _object;

    private event EventHandler OnJsonObjectChanged;

    private static class ObjectToTreeView
    {
        public sealed class IndexContainer
        {
            private int _n;
            public int Inc() => _n++;
        }

        public static void FillTreeView(TreeNode node, JToken tok, Stack<IndexContainer> s)
        {
            if (tok.Type == JTokenType.Object)
            {
                TreeNode n = node;
                if (tok.Parent != null)
                {
                    if (tok.Parent.Type == JTokenType.Property)
                    {
                        n = node.Nodes.Add($"{((JProperty)tok.Parent).Name} <{tok.Type}>");
                    }
                    else
                    {
                        n = node.Nodes.Add($"[{s.Peek().Inc()}] <{tok.Type}>");
                    }
                }
                s.Push(new IndexContainer());
                foreach (var p in tok.Children<JProperty>())
                {
                    FillTreeView(n, p.Value, s);
                }
                s.Pop();
            }
            else if (tok.Type == JTokenType.Array)
            {
                TreeNode n = node;
                if (tok.Parent != null)
                {
                    if (tok.Parent.Type == JTokenType.Property)
                    {
                        n = node.Nodes.Add($"{((JProperty)tok.Parent).Name} <{tok.Type}>");
                    }
                    else
                    {
                        n = node.Nodes.Add($"[{s.Peek().Inc()}] <{tok.Type}>");
                    }
                }
                s.Push(new IndexContainer());
                foreach (var p in tok)
                {
                    FillTreeView(n, p, s);
                }
                s.Pop();
            }
            else
            {
                var value = JsonConvert.SerializeObject(((JValue)tok).Value);

                string name;
                if (tok.Parent.Type == JTokenType.Property)
                {
                    name = $"{((JProperty)tok.Parent).Name} : {value}";
                }
                else
                {
                    name = $"[{s.Peek().Inc()}] : {value}";
                }
                // NEW: store a reference to this token
                node.Nodes.Add(name).Tag = tok;
            }
        }
    }

    public JsonTreeView()
    {
        LabelEdit = true;
        BeforeLabelEdit += OnBeforeLabelEdit;
        AfterLabelEdit += OnAfterLabelEdit;
    }

    private void OnBeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
        e.CancelEdit = e.Node.Tag == null;
    }

    private void OnAfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
        if (string.IsNullOrEmpty(e.Label)) { return; }

        var originalToken = (JToken)e.Node.Tag;
        var newText = e.Label;

        // must have separator
        var indSplit = newText.IndexOf(" :");
        if (indSplit == -1)
        {
            e.CancelEdit = true;
            return;
        }

        // front must match original name
        if (!newText.StartsWith(e.Node.Text.Substring(0, indSplit + 2)))
        {
            e.CancelEdit = true;
            return;
        }

        // new text should have value
        var newTextValue = newText.Substring(indSplit + 2).Trim();
        if (string.IsNullOrWhiteSpace(newTextValue))
        {
            e.CancelEdit = true;
            return;
        }

        // let newtonsoft create a new value based on user entry
        JValue newValue;
        try
        {
            newValue = JsonConvert.DeserializeObject<JValue>(newTextValue);
        }
        catch (JsonReaderException)
        {
            e.CancelEdit = true;
            return;
        }

        // types must match (unless it's null)
        {
            var origType = ((JValue)originalToken).Type;
            if ((origType == JTokenType.Null) || (newValue.Type == JTokenType.Null))
            {
                // we are going to skip this conversion because there is no type
            }
            else
            {
                if (origType != newValue.Type)
                {
                    e.CancelEdit = true;
                    return;
                }
            }
        }

        // set it
        ((JValue)originalToken).Value = newValue?.Value;

        // reset the value incase the value text changed
        e.CancelEdit = true;
        e.Node.Text = $"{e.Node.Text.Substring(0, indSplit + 3)}" +
            $"{JsonConvert.SerializeObject(((JValue)originalToken).Value)}";

        // fire off notification
        OnJsonObjectChanged?.Invoke(this, EventArgs.Empty);
    }

    public void SetJsonObject(object obj)
    {
        BeginUpdate();
        try
        {
            Nodes.Clear();

            var s = new Stack<ObjectToTreeView.IndexContainer>();
            s.Push(new ObjectToTreeView.IndexContainer());
            _object = JsonConvert.DeserializeObject<JToken>(JsonConvert.SerializeObject(obj));
            ObjectToTreeView.FillTreeView(Nodes.Add("ROOT"), _object, s);
            s.Pop();
        }
        finally
        {
            EndUpdate();
        }
    }

    public TResult GetJsonObject<TResult>()
    {
        return JsonConvert.DeserializeObject<TResult>(JsonConvert.SerializeObject(_object));
    }
}
