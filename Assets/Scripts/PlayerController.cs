using Fusion;
using UnityEngine;
using Fusion.Sockets;

public class PlayerController : MonoBehaviour
{
    public void Moving(NetworkInput input)
    {
        var data = new NetworkInputData();

        if (Input.GetKey(KeyCode.W))
        {
            data.Direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            data.Direction += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            data.Direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            data.Direction += Vector3.right;
        }

        input.Set(data);
    }

    public void MouseInput(NetworkInput input)
    {

    }
}
