import { Component, effect, inject, input, output } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { Link, LinkForm } from '../../../models/link';

@Component({
  selector: 'app-link-form',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './link-form.component.html',
  styleUrl: './link-form.component.scss'
})
export class LinkFormComponent {
  link = input<Link>();
  #fb = inject(FormBuilder);

  save = output<LinkForm>()

  form = this.#fb.nonNullable.group({
    name: ['', Validators.required],
    description: [''],
    url: [''],
  })

  constructor() {
    effect(() => {
      this.form.setValue({ name: this.link()?.name || '', description: this.link()?.description || '', url: this.link()?.url || '' })
    })
  }

  handleSave() {
    this.save.emit({ ...this.form.getRawValue(), businessId: this.link()?.businessId })
  }
}
