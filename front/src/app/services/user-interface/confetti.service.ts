import { Injectable } from '@angular/core';
import { Particle } from '../../interfaces/particle';

@Injectable({
  providedIn: 'root'
})
export class ConfettiService {

  public launchConfetti(): void {
    const canvas = document.createElement('canvas')
    const ctx = canvas.getContext('2d')!
    Object.assign(canvas.style, {
      position: 'fixed',
      top: '0',
      left: '0',
      width: '100%',
      height: '100%',
      pointerEvents: 'none',
      zIndex: '9999'
    })
    document.body.appendChild(canvas)
    canvas.width = window.innerWidth
    canvas.height = window.innerHeight

    const colors = ['#FFC700', '#FF0000', '#2E3192', '#41BBC7', '#7F00FF']
    const particles: Particle[] = []
    const count = 200

    for (let i = 0; i < count; i++) {
      particles.push({
        x: Math.random() * canvas.width,
        y: -10,
        vx: (Math.random() - 0.5) * 4,
        vy: Math.random() * 3 + 2,
        size: Math.random() * 8 + 4,
        color: colors[(Math.random() * colors.length) | 0],
        angle: Math.random() * Math.PI * 2,
        va: (Math.random() - 0.5) * 0.1
      })
    }

    const animate = () => {
      ctx.clearRect(0, 0, canvas.width, canvas.height)

      for (const p of particles) {
        ctx.save()
        ctx.fillStyle = p.color
        ctx.translate(p.x, p.y)
        ctx.rotate(p.angle)
        ctx.fillRect(-p.size / 2, -p.size / 4, p.size, p.size / 2)
        ctx.restore()
        p.x += p.vx
        p.y += p.vy
        p.vy += 0.05
        p.vx *= 0.99
        p.angle += p.va
      }

      for (let i = particles.length - 1; i >= 0; i--) {
        if (particles[i].y > canvas.height + 20) particles.splice(i, 1)
      }

      if (particles.length) requestAnimationFrame(animate)
      else document.body.removeChild(canvas)
    }

    animate()
  }
}