using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    protected Vector3 _moveDirection;
    
    protected virtual void  Start()
    {
        _moveDirection = new Vector3(0, 0, -1);
    }

    // with protectec virtual we can override the class in the child objects. otherwise it would stay the same
    protected virtual void  Update()
    {
        move();
    }

    /*
     * Virtual Method so Boulder and Barrel can overwrite it. Stonewall will stay the same.
     */
    protected virtual void move()
    {
        //with space World we make sure, it always moves in the correct direction
        transform.Translate(_moveDirection * (speed * Time.deltaTime), Space.World);
    }
}
