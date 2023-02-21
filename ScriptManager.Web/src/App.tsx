import { useState } from "react";
import reactLogo from "./assets/react.svg";
import "./App.css";
import { Route, Routes } from "react-router-dom";
import { MainLayout } from "./shared/components/layout";
import { ScriptsPage } from "./pages/script/scripts";
import { CreateEditScriptPage } from "./pages/script/create.edit.script";

function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <Routes>
        <Route path="/" element={<MainLayout />}>
          <Route path="/scripts" element={<ScriptsPage />} />
          <Route path="/scripts/:id" element={<CreateEditScriptPage />} />
        </Route>
      </Routes>
    </>
  );
}

export default App;
