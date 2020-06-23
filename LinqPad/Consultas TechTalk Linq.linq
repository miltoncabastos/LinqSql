<Query Kind="Expression">
  <Connection>
    <ID>2596bcff-b1c3-40e8-8604-6e69e1d478f4</ID>
    <Persist>true</Persist>
    <Server>localhost</Server>
    <Database>Insumos</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

UnidadeNegocios
UnidadeNegocios.Take(10)

//--------------------------------------------

Negociacaos.Select(n => n.Id).OrderBy(n => n)
Negociacaos.OrderBy(n => n.Id).Select(n => n.Id)

Negociacaos.Select(n => n.Id)
Negociacaos.AsQueryable().Select(n => n.Id)
Negociacaos.AsEnumerable().Select(n => n.Id)


Negociacaos.Count()
Negociacaos.AsQueryable().Count()
Negociacaos.AsEnumerable().Count()

Negociacaos.OrderBy(n => n.Id).Select(n => n.Id)
Negociacaos.AsEnumerable().OrderBy(n => n.Id).Select(n => n.Id)
Negociacaos.OrderBy(n => n.Id).AsEnumerable().Select(n => n.Id)
Negociacaos.OrderBy(n => n.Id).Select(n => n.Id).AsEnumerable()

//--------------------------------------------

Materials.Select(m => new { m.NumeroMaterial, m.Nome })
Materials.Select(m => $"{m.NumeroMaterial} - {m.Nome}")
Materials.AsEnumerable().Select(m => $"{m.NumeroMaterial} - {m.Nome}")