using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector3 _direction;
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Droite");
            _direction = Vector3.right;
            transform.Translate(_direction);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Guache");
            _direction = Vector3.left;
            transform.Translate(_direction);
        }
    }
}
