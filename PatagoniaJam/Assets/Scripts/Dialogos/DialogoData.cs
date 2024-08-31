using UnityEngine;

[CreateAssetMenu(menuName = "Patagonia/Dialogo")]
public class DialogoData : ScriptableObject
{
    [SerializeField] private int _cantidadDeBasuraNecesaria;
    [SerializeField] private BurbujaDialogoData[] _burbujas = new BurbujaDialogoData[0];

    public BurbujaDialogoData GetBurbuja(int index)
    {
        return _burbujas[index];
    }
}
