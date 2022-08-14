using DreamlandEditor.Data.GameFiles;
using System.Windows.Forms;

namespace DreamlandEditor.UI.Misc
{
    internal class UITreeNode : TreeNode
    {
        public IBaseFile Item { get; set; }

        public UITreeNode(string text, IBaseFile file = null) : base(text)
        {
            Item = file;
        }
    }
}
