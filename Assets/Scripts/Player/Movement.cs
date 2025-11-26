using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    public float speed = 5f;


    private Vector2 vector2InputKey;
    private PlayerControls controls;
    // private Rigidbody2D rd;

    void OnEnable()
    {
        controls.Enable();

        controls.Player.Move.performed += keyboard => vector2InputKey = keyboard.ReadValue<Vector2>();
        controls.Player.Move.canceled += keyboard => vector2InputKey = Vector2.zero;
    }
    void OnDisable()
    {
        controls.Disable();
    }
    void Awake()
    {
        // rd=GetComponent<Rigidbody2D>();

        controls = new PlayerControls();
        
    }
    
    
    
    void Update()
    {
        transform.Translate(vector2InputKey * speed * Time.deltaTime);
    }
}
