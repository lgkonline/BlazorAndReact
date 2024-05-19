import logo from "./logo.svg";
import "./App.css";

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <my-todo Title="From React app as Web Component"></my-todo>
      </header>
    </div>
  );
}

export default App;
