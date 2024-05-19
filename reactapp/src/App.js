import logo from "./logo.svg";
import "./App.css";

function App() {
  return (
    <div className="App">
      <img src={logo} className="App-logo" alt="logo" />
      <my-theme></my-theme>
      <my-todo
        Title="From React app as Web Component"
        AccentTone="#ff0000"
      ></my-todo>
    </div>
  );
}

export default App;
