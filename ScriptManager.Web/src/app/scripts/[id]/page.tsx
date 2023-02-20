import CreateEditScript from "../components/create.edit.script";

async function getData(id: number) {
  const res = await fetch(`http://localhost:5219/api/Script/${id}`);
  // The return value is *not* serialized
  // You can return Date, Map, Set, etc.

  // Recommendation: handle errors
  if (!res.ok) {
    // This will activate the closest `error.js` Error Boundary
    throw new Error("Failed to fetch data");
  }

  return res.json();
}

export default async function CreateEditScriptPage({ params }: any) {
  const { id } = params;
  const script = await getData(Number(id));
  return (
    <>
      <CreateEditScript script={script} />
    </>
  );
}
