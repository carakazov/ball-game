using Domain;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

namespace Providers
{
    public class CollisionEventProvider : IEventProvider
    {
        private Player player;

        public CollisionEventProvider(Player player)
        {
            this.player = player;
        }

        public UnityEvent DefineCollisionEvent(Collision collision)
        {
            UnityEvent unityEvent = new UnityEvent();
            HitableCheck(unityEvent, collision);
            PickableCheck(unityEvent, collision);
            BonusCheck(unityEvent, collision);
            return unityEvent;
        }


        private void HitableCheck(UnityEvent unityEvent, Collision collision)
        {
            IHitable hitable = collision.gameObject.GetComponent<IHitable>();
            if (hitable!= null)
            {
                unityEvent.AddListener(hitable.Hit);
            }
        }


        private void PickableCheck(UnityEvent unityEvent, Collision collision)
        {
            IPickable pickable = collision.gameObject.GetComponent<IPickable>();
            if (player != null)
            {
                unityEvent.AddListener(pickable.Pick);
            }
        }

        private void BonusCheck(UnityEvent unityEvent, Collision collision)
        {
            IBonus bonus = collision.gameObject.GetComponent<IBonus>();
            if (bonus != null)
            {
                unityEvent.AddListener(bonus.Add);
            }
        }
    }
}