import logo from './logo.svg';
import './App.scss';
import { StudentsDisplay } from './features/students/StudentsDisplay';
import { Crud } from './features/students/Crud';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <Crud />
        <StudentsDisplay />
      </header>
    </div>
  );
}

export default App;
