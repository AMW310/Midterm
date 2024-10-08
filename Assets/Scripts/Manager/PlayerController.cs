using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static Actions _actions;
    private static Player _player;
    public static void Init(Player player)
    {
        _actions = new Actions();
        _player = player;

        _actions.Player.Move.performed += ctx => _player.Move(ctx.ReadValue<Vector2>());
        _actions.Player.Attack.performed += ctx => _player.Attack(ctx.ReadValueAsButton());
    }

    public static void GameState()
    {
        _actions.Player.Enable();
    }

    public static void DisableGame()
    {

    }
}
