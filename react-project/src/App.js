import Louvor from './Views/Louvor/Louvor';
import Midias from './Views/Midias/Midias';
import NotFound from './Views/NotFound/NotFound';
import { Routes, Route } from "react-router-dom";
import './App.css'

function App() {
  return (
    <div className="App">
        <Routes>
          <Route path="/" element={<Louvor />} />
          <Route path="/Louvor" element={<Louvor />} />
          <Route path="/Midias" element={<Midias />} />
          <Route path="*" element={<NotFound />} />
        </Routes>

    </div>
  );
}

export default App;
