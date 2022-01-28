using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class AspectUpdateExample : MonoBehaviour
{
    private RectTransform _transform;
    private Material _mat;
    private static readonly int Aspect = Shader.PropertyToID("_Aspect");

    // Start is called before the first frame update
    async void Start()
    {
        _transform = GetComponent<RectTransform>();
        await Task.Yield();
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        _mat = GetComponent<MaskableGraphic>().materialForRendering;
        var rect = _transform.rect;
        _mat.SetFloat(Aspect, rect.height / rect.width);
    }
}
