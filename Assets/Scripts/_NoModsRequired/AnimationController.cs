using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Routes game state and to the unity animator on this GO/children, also handles display of built in feedback such as character mojo
/// 
/// NOTE: Provided with framework, no modification required
/// TODO: Nothing
/// </summary>
public class AnimationController : MonoBehaviour
{
    private Animator anim;
    public Light ourSpot;
    public float baseLightInten, selectedInten, defeatedInten;
    public float lightIntenLerpSpeed = 10;
    protected Character character;
    protected StatsSystem stats;
    public AnimationCurve mojoToSpeedCurve = AnimationCurve.Linear(0, 1, 1, 1);

    [SerializeField]
    protected Image hpImage;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        character = GetComponentInChildren<Character>();
        stats = GetComponentInChildren<StatsSystem>();
    }

    public void BattleResult(Character winner, Character defeated, float outcome)
    {
        if (winner.gameObject == gameObject)
        {
            anim.SetTrigger("Win");
        }
        else if (defeated.gameObject == gameObject)
        {
            if (outcome == 0)
            {
                anim.SetTrigger("Win");
            }
            else
            {
                anim.SetTrigger("Lose");
            }
        }
    }

    private void Update()
    {

        if(character != null)
        {
            ourSpot.intensity = Mathf.Lerp(ourSpot.intensity, character.isSelected ? selectedInten : baseLightInten, lightIntenLerpSpeed * Time.deltaTime);
            ourSpot.intensity = Mathf.Lerp(defeatedInten, ourSpot.intensity, character.myStatsSystem.playerHealth);
        }

        if(stats != null)
        {
            anim.speed = mojoToSpeedCurve.Evaluate(1 - stats.playerHealth);
        }
        else
        {
            anim.speed = 1;
        }

        if (hpImage != null && stats != null)
        {
            hpImage.fillAmount = Mathf.Lerp(hpImage.fillAmount, stats.playerHealth, Time.deltaTime);
        }
    }

    public void Dance()
    {
        anim.SetTrigger("Dance");
    }
}
