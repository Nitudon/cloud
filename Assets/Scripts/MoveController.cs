using Cloud.GameEnums;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveController : MonoBehaviour {

    [SerializeField]
    private Rigidbody _rigidbody;

    private MoverMode _mode;

    public void Initialize(MoverMode mode){
        _mode = mode;
    }

    public void SetMoveDirection(){

    }

}
