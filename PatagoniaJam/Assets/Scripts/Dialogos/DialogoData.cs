using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

[CreateAssetMenu(menuName = "Patagonia/Dialogo")]
public class DialogoData : ScriptableObject
{
    [Header("Activacion")]
    [SerializeField, Tooltip("Si esta casilla esta marcada, el dialogo se dispara solo cuando el conserge limpie la cantidad necesaria")]
    private bool _dependeDeBasura = true;
    [SerializeField] private int _cantidadDeBasuraNecesaria;

    [Header("Activacion")]
    [SerializeField, Tooltip("Indica que tan visible es la orca.\nEn 0 la ballena es invisible, en 1 es total mente visible")]
    [Min(0)]
    private float _transparenciaDeBallena;

    [Header("Dialogos")]
    [SerializeField] private BurbujaDialogoData[] _burbujas = new BurbujaDialogoData[0];

    public int GetLength()
    {
        return _burbujas.Length;
    }

    public BurbujaDialogoData GetBurbuja(int index)
    {
        return _burbujas[index];
    }

    public bool TieneBasuraNecesaria(int index)
    {
        return _dependeDeBasura && _cantidadDeBasuraNecesaria == index;
    }
}