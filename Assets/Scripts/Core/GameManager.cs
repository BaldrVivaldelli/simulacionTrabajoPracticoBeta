using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private HumanoProvider _humanoProvider;
    private ZombieProvider _zombieProvider;
    private WaitForEndOfFrame wait = new WaitForEndOfFrame();
    public Text zombieText;
    public Text humanoText;
    public Text endText;
    public Text instrucciones;
    private bool end;

    void Start()
    {
        end = false;
        StartCoroutine(Initialize());
    }

    void Update()
    {

    }

    public void UpdateUI()
    {
        UpdateZombieUI();
        UpdateHumanoUI();
    }

    private void UpdateZombieUI()
    {
        zombieText.text = _zombieProvider.GetCount().ToString();
    }

    private void UpdateHumanoUI()
    {
        humanoText.text = _humanoProvider.GetCount().ToString();
    }

    private IEnumerator Initialize()
    {
        ActivateProviders();
        yield return wait;
        ActivateNPC(_humanoProvider.GetList());
        yield return wait;
        ActivateNPC(_zombieProvider.GetList());
        yield return wait;
        UpdateZombieUI();
        yield return wait;
        UpdateHumanoUI();
    }

    private void ActivateProviders()
    {
        FindObjectOfType<PuntoProvider>().GetComponent<PuntoProvider>().enabled = true;

        _humanoProvider = FindObjectOfType<HumanoProvider>();
        _humanoProvider.GetComponent<HumanoProvider>().enabled = true;

        _zombieProvider = FindObjectOfType<ZombieProvider>();
        _zombieProvider.GetComponent<ZombieProvider>().enabled = true;
    }

    private void ActivateNPC(List<GameObject> list)
    {
        foreach (GameObject item in list)
        {
            item.GetComponent<MonoBehaviour>().enabled = true;
        }
    }
}
