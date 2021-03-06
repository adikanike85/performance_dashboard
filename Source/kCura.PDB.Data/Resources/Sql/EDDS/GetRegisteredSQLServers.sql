/* Get active SQL servers registered with Relativity */
SELECT
    RS.[ArtifactID],
    RS.[Name],
    RS.[Status],
    RS.[Version],
	A.TextIdentifier AS ServerType
  FROM [EDDS].[eddsdbo].[ResourceServer] RS WITH(NOLOCK)
  INNER JOIN [EDDS].[eddsdbo].[Artifact] A WITH(NOLOCK)
  ON RS.[Type] = A.ArtifactID
  INNER JOIN [EDDS].[eddsdbo].[Code] C WITH(NOLOCK)
  ON RS.[Status] = C.ArtifactID
  INNER JOIN [EDDS].[eddsdbo].[CodeType] CT WITH(NOLOCK)
  ON CT.CodeTypeID = C.CodeTypeID
  WHERE
    CT.Name = 'ResourceServerStatus' AND
    C.Name = 'Active' AND
    A.TextIdentifier IN ('SQL - Primary', 'SQL - Distributed')