﻿Namespace GameModes.Maps.Primitives

    Class SignModel

        Inherits PrimitiveModel

        Public Sub New()
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, 0.1), New Vector3(0, 0, 1), New Vector2(0.0, 1.0))) 'h
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, 0.1), New Vector3(0, 0, 1), New Vector2(0.0, 0.0))) 'e
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, 0.1), New Vector3(0, 0, 1), New Vector2(1.0, 1.0))) 'c

            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, 0.1), New Vector3(0, 0, 1), New Vector2(1.0, 1.0))) 'c
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, 0.1), New Vector3(0, 0, 1), New Vector2(0.0, 0.0))) 'e
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, 0.5, 0.1), New Vector3(0, 0, 1), New Vector2(1.0, 0.0))) 'd

            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, 0.1), New Vector3(1, 0, 0), New Vector2(0.0, 1.0))) 'c
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, 0.5, 0.1), New Vector3(1, 0, 0), New Vector2(0.0, 0.0))) 'd
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, -0.1), New Vector3(1, 0, 0), New Vector2(1.0, 1.0))) 'b

            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, -0.1), New Vector3(1, 0, 0), New Vector2(1.0, 1.0))) 'b
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, 0.5, 0.1), New Vector3(1, 0, 0), New Vector2(0.0, 0.0))) 'd
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, 0.5, -0.1), New Vector3(1, 0, 0), New Vector2(1.0, 0.0))) 'g

            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, 0.1), New Vector3(-1, 0, 0), New Vector2(1.0, 0.0))) 'e
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, 0.1), New Vector3(-1, 0, 0), New Vector2(1.0, 1.0))) 'h
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, -0.1), New Vector3(-1, 0, 0), New Vector2(0.0, 1.0))) 'a

            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, -0.1), New Vector3(-1, 0, 0), New Vector2(0.0, 1.0))) 'a
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, -0.1), New Vector3(-1, 0, 0), New Vector2(0.0, 0.0))) 'f
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, 0.1), New Vector3(-1, 0, 0), New Vector2(1.0, 0.0))) 'e

            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, -0.1), New Vector3(0, 0, -1), New Vector2(1.0, 0.0))) 'f
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, -0.1), New Vector3(0, 0, -1), New Vector2(1.0, 1.0))) 'a
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, -0.1), New Vector3(0, 0, -1), New Vector2(0.0, 1.0))) 'b

            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, -0.1), New Vector3(0, 0, -1), New Vector2(0.0, 1.0))) 'b
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, 0.5, -0.1), New Vector3(0, 0, -1), New Vector2(0.0, 0.0))) 'g
            vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, 0.5, -0.1), New Vector3(0, 0, -1), New Vector2(1.0, 0.0))) 'f

            Setup()
        End Sub

    End Class

End Namespace
