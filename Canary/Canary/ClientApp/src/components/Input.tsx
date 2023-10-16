import React, { Component } from 'react';
import InputBox from "./InputBox";
import './Input.css'

export class Input extends Component {
    static displayName = Input.name;

    render() {
        return (
            <div className="input-box">
                <InputBox></InputBox>
            </div>
        );
    }
}

