using UnityEngine;

[CreateAssetMenu()]
public class DialogoData : MonoBehaviour
{
    [SerializeField] private int _cantidadDeBasuraNecesaria;
    [SerializeField] private BurbujaDialogoData[] _burbujas = new BurbujaDialogoData[0];

    public BurbujaDialogoData GetBurbuja(int index)
    {
        return _burbujas[index];
    }
}
