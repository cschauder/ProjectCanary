import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import NumberList from "./NumbersList";
import './Home.css';


export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div className="list-component">
                <h1>Number List</h1>
                <NumberList></NumberList>
                <Link to="/input" className="btn btn-primary">Create Input</Link>
            </div>
        );
    }
}