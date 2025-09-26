using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector3 _direction;
    [SerializeField] private float _vitesseJoueur = 10f;
    [SerializeField] private float _vitesseRotationJoueur = 1000f;

    private void Update()
    {
        MouvementsJoueur();
    }

    private void MouvementsJoueur()
    {
        float directionX = Input.GetAxis("Horizontal");
        float directionY = Input.GetAxis("Vertical");
        Debug.Log("Horizontal");

        _direction = new Vector3(directionX, 0f, directionY);

        _direction.Normalize(); //Vecteur be dépasse pas 1

        transform.Translate(_direction * Time.deltaTime * _vitesseJoueur);

        // Rotation dans la direction du movement
        if(_direction != Vector3.zero)
        { 
            Quaternion directionRotation = Quaternion.LookRotation(_direction, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, directionRotation, _vitesseRotationJoueur * Time.deltaTime);
        }
    }
}
