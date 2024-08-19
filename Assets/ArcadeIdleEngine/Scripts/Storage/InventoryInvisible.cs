using System;
using ArcadeBridge.ArcadeIdleEngine.Helpers;
using ArcadeBridge.ArcadeIdleEngine.Items;
using UnityEngine;

namespace ArcadeBridge.ArcadeIdleEngine.Storage
{
    [Serializable]
	public class InventoryInvisible : InventoryBase
	{
		[SerializeField] int _capacity;
		
		public override bool IsFull() => Count >= _capacity;

		public void SetCapacity(int capacity)
		{
			_capacity = capacity;
		}

		protected override void OnAdding(Item item)
		{
			Transform trans = item.transform;
			TweenHelper.KillAllTweens(trans);
			trans.SetParent(StackingPoint);
			item.JumpAndDisappear(Vector3.zero, 2f, PickUpDuration);
		}
	}
}
