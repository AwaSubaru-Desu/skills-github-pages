// HoverMotion.cs
public class HoverMotion : MonoBehaviour {
    [Header("悬浮参数")]
    public float hoverHeight = 1.0f; // 悬浮基准高度
    public float floatSpeed = 2.0f;  // 浮动速度
    public float rotateSpeed = 15f;  // 旋转速度

    private Vector3 startPos;

    void Start() {
        startPos = transform.position;
    }

    void Update() {
        // Y轴上下浮动
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * 0.3f;

        // 缓慢旋转
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

        transform.position = new Vector3(
            startPos.x,
            newY,
            startPos.z
        );
    }
}
