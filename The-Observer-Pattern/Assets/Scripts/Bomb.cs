using UnityEngine;

public class Bomb : MonoBehaviour
{
    public delegate void BombExplosionDelegate(Bomb bomb);
    public event BombExplosionDelegate BombExplosionEvent;

    private void Start()
    {
        Explosion();
    }

    private void Explosion()
    {
        BombExplosionEvent?.Invoke(this);
    }
}
