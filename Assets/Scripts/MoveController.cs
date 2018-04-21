using Cloud.GameEnums;
using Cloud.GameParameters;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveController : MonoBehaviour {

    [SerializeField]
    private Rigidbody _rigidbody;

    private MoverMode _mode;

    public void Initialize(MoverMode mode){
        _mode = mode;
    }

    public void SetMoveDirection(Direction dir){
        switch(dir){
            case Direction.None:
                _rigidbody.velocity = Vector2.zero;
                break;

            case Direction.Right:
                _rigidbody.velocity = GameParameter.DEFAULT_MOVE_SPEED * Vector2.right;
                break;

            case Direction.Left:
                _rigidbody.velocity = GameParameter.DEFAULT_MOVE_SPEED * Vector2.left;
                break;
        }
    }

}
