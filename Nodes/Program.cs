using Nodes;

Nodes.Nodes en = new EquidistantNodes(1, 4, 4);
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(en[i]);
}
Nodes.Nodes cn = new ChebishevNodes(1, 4, 4);
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(cn[i]);
}