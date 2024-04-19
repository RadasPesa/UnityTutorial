
using System.Collections;
using UnityEngine;

public class PotAnimator : MonoBehaviour
{
    private Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    public void Break()
    {
        animator.SetBool("Destroy", true);
        StartCoroutine(CleanPot());
    }

    private IEnumerator CleanPot()
    {
        yield return null;
        while (animator.GetCurrentAnimatorStateInfo(0).IsName("PotDestroy"))
        {
            yield return null;
        }
        Destroy(gameObject);
    }
}
