using DreamlandEditor.Data.GameFiles;
using System.Windows.Forms;

namespace DreamlandEditor.UI.Misc
{
    internal class UITreeNode : TreeNode
    {
        public BaseFile Item { get; set; }

        public UITreeNode(string text, BaseFile file = null) : base(text)
        {
            Item = file;
        }
    }
}
