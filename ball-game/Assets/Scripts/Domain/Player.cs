using System;
using Providers;
using UnityEngine;
using UnityEngine.Events;

namespace Domain
{
    public class Player : MonoBehaviour, IDie, IDamageable
    {
        private IEventProvider eventProvider;
        private UnityEvent unityEvent;
        
        public int Score { get; set; }
        private void Start()
        {
            eventProvider = new CollisionEventProvider(this);
            throw new NotImplementedException();
        }

        private void Update()
        {
            Coin coin = new Coin();
            throw new NotImplementedException();
        }

        private void OnCollisionEnter(Collision other)
        {
            unityEvent = eventProvider.DefineCollisionEvent(other);
            unityEvent.Invoke();
        }

        public void Die()
        {
            throw new System.NotImplementedException();
        }
        
        public void TakeDamage()
        {
            throw new System.NotImplementedException();
        }
    }
}