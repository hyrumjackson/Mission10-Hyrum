import React from 'react'; // Ensure React is in scope when using JSX
import logo from './bowlinglogo.jpg';

interface HeaderProps {
  title: string; // The main title for the header
  description?: string; // An optional subtitle or description
}

function Header({ title, description }: HeaderProps) {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" width="200px" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{title}</h1>
        {description && <p className="text-white">{description}</p>}{' '}
      </div>
    </header>
  );
}

export default Header;
