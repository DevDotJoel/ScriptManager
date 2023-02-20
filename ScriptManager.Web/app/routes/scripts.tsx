import { json } from "@remix-run/node";
import { useLoaderData } from "@remix-run/react";

export async function loader() {
  const res = await fetch("http://localhost:5219/api/Script");
  return json(await res.json());
}

export default function Scripts() {
  const scripts = useLoaderData<typeof loader>();
  console.log(scripts);
  return (
    <>
      <h1>hello</h1>
    </>
  );
}
