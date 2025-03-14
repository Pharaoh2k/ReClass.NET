namespace ReClassNET.Nodes
{
	public abstract class BaseClassWrapperNode : BaseWrapperNode
	{
		public override void Initialize()
		{
			var node = ClassNode.Create();
			node.Initialize();
			LevelsOpen.DefaultValue = true;
			ChangeInnerNode(node);
		}

		public override bool CanChangeInnerNodeTo(BaseNode node)
		{
			return node is ClassNode;
		}
	}
}
