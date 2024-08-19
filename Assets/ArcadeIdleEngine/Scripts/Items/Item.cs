using ArcadeBridge.ArcadeIdleEngine.Helpers;
using UnityEngine;

namespace ArcadeBridge.ArcadeIdleEngine.Items
{
    public class Item : MonoBehaviour
    {
        [SerializeField] ItemDefinition _definition;
        
        Vector3 _defaultLocalScale;
        
        public ItemDefinition Definition => _definition;

        void Awake()
        {
            _defaultLocalScale = transform.localScale;
        }

        public void ReleaseToPool()
        {
            transform.localScale = _defaultLocalScale;
            TweenHelper.KillAllTweens(transform);
            _definition.Pool.PutBackToPool(this);
        }
        
        public void JumpAndDisappear(Vector3 targetPoint, float jumpPower, float duration)
        {
            TweenHelper.LocalJumpAndRotate(transform, targetPoint, Vector3.zero, jumpPower, duration, DisappearSlowlyToPool);
        }
        
        void DisappearSlowlyToPool()
        {
            TweenHelper.DisappearSlowly(transform, 0.2f, ReleaseToPool);
        }
    }
}