using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ParticleOnTap : MonoBehaviour
{
    public GameObject particle;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void OnMouseDown()
    {
        GameObject newParticle = Instantiate(particle, transform.position, Quaternion.identity);
        newParticle.GetComponent<ParticleSystemRenderer>().sharedMaterial = new Material(Shader.Find("Standard"));
        newParticle.GetComponent<ParticleSystemRenderer>().sharedMaterial.color = meshRenderer.material.color;
        AddScore.inGameScore.AddScoreOnTap();
        Destroy(gameObject.transform.parent.gameObject);
    }
}
