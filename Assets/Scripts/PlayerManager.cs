using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private Player _player;
    private GameInputs _input;
    // Start is called before the first frame update
    void Start()
    {
        InitializeInputs();
    }

    void InitializeInputs()
    {
        _input = new GameInputs();
        _input.Player.Enable();
        //_input.Player.Fire.performed += Fire_performed;
    }

    // Update is called once per frame
    void Update()
    {
        var move = _input.Player.Movement.ReadValue<Vector2>();
        _player.Move(move);
        //communicate this to the player so you can move
    }
}
