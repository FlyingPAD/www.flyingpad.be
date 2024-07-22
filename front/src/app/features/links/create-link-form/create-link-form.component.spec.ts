import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateLinkFormComponent } from './create-link-form.component';

describe('CreateLinkFormComponent', () => {
  let component: CreateLinkFormComponent;
  let fixture: ComponentFixture<CreateLinkFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CreateLinkFormComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateLinkFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
