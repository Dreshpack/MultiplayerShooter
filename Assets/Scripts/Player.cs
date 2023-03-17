using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class Player : NetworkBehaviour
{
    private NetworkCharacterControllerPrototype _netCharCont;

    private void Awake()
    {
        _netCharCont = GetComponent<NetworkCharacterControllerPrototype>();
    }

    public override void FixedUpdateNetwork()
    {
        if(GetInput(out NetworkInputData data))
        {
            data.Direction.Normalize();
            _netCharCont.Move(5 * data.Direction * Runner.DeltaTime);
        }
    }
}
