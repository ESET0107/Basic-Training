import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  let count = 0;
  const increment = ()=>{
    count++;
    document.getElementById("123").innerText = count
  }
  const decrement = ()=>{
    count--;
    document.getElementById("123").innerText = count
  }
  return(
    <div>
      <h1 id = "123">0</h1>
      <button onClick={increment}>INCREMENT</button>
      <button onClick={decrement}>DECREMENT</button>
    </div>
  )
}

export default App
