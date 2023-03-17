using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using Fusion.Sockets;
using System.Threading.Tasks;
using System.Linq;

public class NetworkRunnerHendler : MonoBehaviour
{
    private NetworkRunner _networkRunner;
    public NetworkRunner NetworkRunner
    {
        get
        {
            return _networkRunner;
        }
    }
}
