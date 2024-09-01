using UnityEngine;

[CreateAssetMenu(menuName = "Patagonia/Dialogo")]
public class DialogoData : ScriptableObject
{
    [SerializeField, Tooltip("Si esta casilla esta marcada, el dialogo se dispara solo cuando el conserge limpie la cantidad necesaria")]
    private bool _dependeDeBasura = true;
    [SerializeField] private int _cantidadDeBasuraNecesaria;
    [SerializeField] private BurbujaDialogoData[] _burbujas = new BurbujaDialogoData[0];

    public BurbujaDialogoData GetBurbuja(int index)
    {
        return _burbujas[index];
    }
}
