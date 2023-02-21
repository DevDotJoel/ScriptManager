import Link from "next/link";
import Scripts from "./components/scripts";

async function getData() {
  const res = await fetch(
    "https://scriptmanagerapi.azurewebsites.net/api/Script",
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

export default async function Page() {
  const scripts = await getData();
  return <>{<Scripts currentScripts={scripts} />}</>;
}
