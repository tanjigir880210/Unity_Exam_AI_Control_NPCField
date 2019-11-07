using UnityEngine;

public class Robotball : MonoBehaviour
{
    [Range(0, 1000), Header("跳躍")]
    public float jump = 69;

    [Range(0, 1000), Header("速度")]
    public float speed = 50;

    [Header("是否在地板上")]
    public bool isGround = true;

    private Rigidbody r3d;

    void Start()
    {

        r3d = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;
    }

    private void FixedUpdate()
    {
        Jump();
        Walk();
    }

    /// <summary>
    /// 走路
    /// </summary>
    private void Walk()
    {
        r3d.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0, speed * Input.GetAxis("Vertical")));
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r3d.AddForce(new Vector3(0, jump, 0));
        }
    }
}
