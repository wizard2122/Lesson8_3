using UnityEngine;

public class PlayerBootstrap : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Awake()
    {
        _player.Initialize(new AngelHealth(new ElfHealth(new Health(50), 2), 4, 4, this));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _player.TakeDamage(6);

        if (Input.GetKeyDown(KeyCode.F))
            _player.Heal(6);
    }
}