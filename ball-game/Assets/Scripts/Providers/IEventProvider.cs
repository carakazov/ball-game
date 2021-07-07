using UnityEngine;
using UnityEngine.Events;

namespace Providers
{
    public interface IEventProvider
    {
        UnityEvent DefineCollisionEvent(Collision collision);
    }
}