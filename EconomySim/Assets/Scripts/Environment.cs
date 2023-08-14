using System.Collections.Generic;
using UnityEngine;

public class Chunk
{

}

public class Environment : MonoBehaviour
{
    //[SerializeField]
    Dictionary<Vector2Int, Chunk> chunks = new Dictionary<Vector2Int, Chunk>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void LoadChunk(Vector2Int chunk)
    {
        if( chunks.ContainsKey( chunk ) )
            return;


    }

    private void UnloadChunk(Vector2Int chunk)
    {
        if( !chunks.ContainsKey( chunk ) )
            return;

    }
}
