import BowlerList from './BowlerList'

function Welcome() {
  return (
    <>
      <header className="welcome-header">
        <h1>Welcome to the Bowling League Tracker</h1>
        <p>Browse and explore details about bowlers and their teams!</p>
      </header>
    </>
  );
}


function App() {

  return (
    <>
      <Welcome/>
      <BowlerList/>
    </>
  );
}

export default App
