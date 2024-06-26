import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateStyleComponent } from './create-style.component';

describe('CreateStyleComponent', () => {
  let component: CreateStyleComponent;
  let fixture: ComponentFixture<CreateStyleComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CreateStyleComponent]
    });
    fixture = TestBed.createComponent(CreateStyleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
