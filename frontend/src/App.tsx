import './App.css';
import BowlerList from './Bowler/BowlerList';
import Header from './Header';

function App() {
  return (
    <div className="App">
      <Header
        title="Bowlers"
        description="A comprehensive list of bowlers in the league"
      />
      <BowlerList />
    </div>
  );
}

export default App;
