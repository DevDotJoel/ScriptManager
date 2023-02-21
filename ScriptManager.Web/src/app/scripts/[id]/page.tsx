import CreateEditScript from "../components/create.edit.script";

async function getData(id: number) {
  const res = await fetch(
    `https://scriptmanagerapi.azurewebsites.net/api/Script/${id}`,
    { cache: "no-store" }
  );
  // The return value is *not* serialized
  // You can return Date, Map, Set, etc.

  // Recommendation: handle errors
  if (!res.ok) {
    // This will activate the closest `error.js` Error Boundary
    throw new Error("Failed to fetch data");
  }

  return await res.json();
}

export default async function CreateEditScriptPage({ params }: any) {
  const { id } = params;
  const script = id ? await getData(Number(id)) : null;

  return (
    <>
      <CreateEditScript data={script} />
    </>
  );
}
