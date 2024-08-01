using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_2_2TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // 텍슨트 박스 값을 가진 TreeNode 객체 생성
            TreeNode node1 = new TreeNode(tbNode.Text);
            // 트리 뷰에서 선택된 노드가 있는지 SelectedNode를 통해 체크
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.IsSelected)
                treeView1.SelectedNode.Nodes.Add(node1);    //선택된 노드가 있으면 노드하위에 Add()
            else treeView1.Nodes.Add(node1);    // 없으면 노드에 Add()
            tbNode.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //트리 뷰에서 선택된 노드가 있는지 SelectedNode를 통해 체크
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.IsSelected)
                treeView1.SelectedNode.Remove();    // 있으면 Remove()
        }

        private void BtnExpandAll_Click(object sender, EventArgs e)
        {
            //모든 트리를 확장해서 보여줌
            treeView1.ExpandAll();
        }

        private void BtnCollapseAll_Click(object sender, EventArgs e)
        {
            //모든 트리를 축소해서 보여줌
            treeView1.CollapseAll();
        }

        
        void RemoveCheckedNodes(TreeNodeCollection nodes)
        {
            //체크한 노드만 삭제하기 위한 기능
            //전달인자로 TreeNodeCollection 객체를 전달
            List<TreeNode> chkNodes = new List<TreeNode>();
            foreach (TreeNode node in nodes)
            {
                //노드가 체크인지 확인해서 맞으면 chkNodes에 추가
                if (node.Checked) chkNodes.Add(node);
                else RemoveCheckedNodes(node.Nodes);    // 아니면 하위노드 확인
            }

            // chkNodes을 처음부터 마지막까지 확인해서 체크노드 삭제
            foreach (TreeNode chknode in chkNodes)
            {
                nodes.Remove(chknode);
            }
        }

        private void BtnChkDelete_Click(object sender, EventArgs e)
        {
            // 버튼 클릭시 메소드 호출해서 삭제
            RemoveCheckedNodes(treeView1.Nodes);
        }
    }
}
