using UnityEngine;

namespace Domain
{
    public class Coin : SimplePickable, IPickable
    {
        [SerializeField] private Player player;
        public void Pick()
        {
            player.Score += value;
            Destroy(gameObject);
        }
    }
}