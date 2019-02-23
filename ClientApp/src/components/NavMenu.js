import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
      <header className="navbar box-shadow">
        <ul className="nav">
          <li>Fifa coins Logo</li>
          <li><span className="icon"><i className="fa fa-car"></i> </span><span className="text"> Kup żetony</span></li>
          <li><span className="icon"><i className="fas fa-atom"></i> </span><span className="text"> Zamów bota</span></li>
        </ul>
      </header>
    );
  }
}
